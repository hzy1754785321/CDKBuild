using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.IO;

namespace CDKBuild
{
    public partial class Form1 : Form
    {

        public List<string> pro = new List<string>();
        public List<string> yuanList = new List<string>();
        public List<string> copyList = new List<string>();
        public Stopwatch stop = new Stopwatch();
        public Thread thread;
        public Thread thread1;
        public int number;
        public int repeat;
        public string type;
        public string id;
        public Form1()
        {
            InitializeComponent();
        }


        public async void build(object sender, EventArgs e)
        {
            //      try
            //     {
            type = typeText.Text;
            id = IDText.Text;
            number = Convert.ToInt32(numberText.Text);
            showList.Items.Clear();
            var result = new Structure();
            int randCount = Convert.ToInt32(lengthText.Text) - 6;
            if (randCount <= 3)
            {
                MessageBox.Show("长度不能少于9");
                return;
            }
            thread = new Thread(new ThreadStart(Create));
            thread.Start();
            thread.IsBackground = true;
            Resultpanel.Visible = true;
            thread1 = new Thread(new ThreadStart(Create));
            thread1.IsBackground = true;
            thread1.Start();
            var thread2 = new Thread(new ThreadStart(CreateCSV));
            thread2.IsBackground = true;
            thread2.Start();
            /*       if (pro.Find(c => c == tss) != null)  //性能太差
                   {
                       repeat++;
                   }
                   pro.Add(tss);  */


            //       }
            /*       catch (Exception ex)
                   {
                       MessageBox.Show("生成失败");
                       showList.Items.Add(ex.StackTrace);
                       return;
                   }  */
        }



        public void Create()
        {
            CheckForIllegalCrossThreadCalls = false;
            stop.Start();
            int randCount = Convert.ToInt32(lengthText.Text) - 6;
            for (int x = 0; x < number / 2; x++)
            {
                Random rand = new Random(GetRandomSeed());
                int start = (int)Math.Pow(10, randCount);
                int end = 99 * (int)Math.Pow(10, randCount);
                var randNumber = rand.Next(start, end);
                var time = DateTime.UtcNow;
                var timeTemp = Encoding.UTF8.GetBytes(time.ToString());
                var typeTemp = Encoding.UTF8.GetBytes(id + type);
                var randTemp = new byte[randCount];
                rand.NextBytes(randTemp);
                var temp = new byte[4];
                for (int i = 0, j = timeTemp.Length - 1; i < 4; i++, j--)
                {
                    temp[i] = (byte)(timeTemp[j] ^ typeTemp[i] ^ randTemp[i]);
                }
                var ts = BitConverter.ToInt32(temp, 0);
                var str = Convert.ToString(ts, 16);
                var idStr = str.Take(5).ToArray();
                var strRand = Convert.ToString(randNumber, 16);
                var randTemps = strRand.Take(randCount).ToArray();
                List<char> r = new List<char>();
                r.AddRange(idStr);
                r.AddRange(randTemps);
                var source = r.ToArray();
                var check = (int)(CalSum(source) ^ 0xFF) % 16;  //checksum校验
                var checksum = Convert.ToString(check, 16);
                r.Clear();
                r.AddRange(source);
                r.AddRange(checksum);
                source = r.ToArray();
                var tss = string.Join("", source).ToUpper();
                showList.Items.Add(tss);
                yuanList.Add(tss);
            }
         
        }

        public void CreateCSV()
        {
            while (true)
            {
                if (!thread.IsAlive && !thread1.IsAlive)
                {

                    Hashtable hash = new Hashtable();
                    foreach (string str in yuanList)
                    {
                        if (str != null)
                        {
                            if (!hash.ContainsKey(str))
                            {
                                hash.Add(str, str);
                                copyList.Add(str);
                            }
                            else
                            {
                                repeat++;
                            }
                        }
                        else
                        {
                            repeat++;
                        }
                    }
                    stop.Stop();
                    var supply = Supply(number-copyList.Count);
                    repeatText.Text = string.Format("{0}个    已补充{1}个",repeat,supply);
                    timeText.Text = stop.Elapsed.TotalSeconds + "s";
                    successText.Text = yuanList.Count.ToString();
                    var csv = new StringBuilder();
                    var time = DateTime.Now.Date.ToString("-yyyy-MM-dd");
                    var csvPath = Path.Combine(Application.StartupPath, type + id +"-" + tableName.Text + time + ".csv");
                    using (FileStream fs = new FileStream(csvPath.Trim(), FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                        {
                            StringBuilder sb_csvStr = new StringBuilder();
                            for (int i = 0; i < copyList.Count; i++)
                            {
                                sb_csvStr.Clear();
                                for (int j = 0; j < copyList[i].Length; j++)
                                {
                                    sb_csvStr.Append(string.Format("{0}", copyList[i][j].ToString()));
                                }
                                sw.WriteLine(sb_csvStr.ToString().Substring(0, sb_csvStr.ToString().Length - 1));
                            }
                            fs.Flush();
                        }
                    }
                    MessageBox.Show("生成成功");
                    break;
                }
            }

        }

        public int Supply(int number)
        {
            var randCount = Convert.ToInt32(lengthText.Text) - 6;
            int supply = 0;
            for (int x = 0; x < number; x++)
            {
                Random rand = new Random(GetRandomSeed());
                int start = (int)Math.Pow(10, randCount);
                int end = 99 * (int)Math.Pow(10, randCount);
                var randNumber = rand.Next(start, end);
                var time = DateTime.UtcNow;
                var timeTemp = Encoding.UTF8.GetBytes(time.ToString());
                var typeTemp = Encoding.UTF8.GetBytes(id + type);
                var randTemp = new byte[randCount];
                rand.NextBytes(randTemp);
                var temp = new byte[4];
                for (int i = 0, j = timeTemp.Length - 1; i < 4; i++, j--)
                {
                    temp[i] = (byte)(timeTemp[j] ^ typeTemp[i] ^ randTemp[i]);
                }
                var ts = BitConverter.ToInt32(temp, 0);
                var str = Convert.ToString(ts, 16);
                var idStr = str.Take(5).ToArray();
                var strRand = Convert.ToString(randNumber, 16);
                var randTemps = strRand.Take(randCount).ToArray();
                List<char> r = new List<char>();
                r.AddRange(idStr);
                r.AddRange(randTemps);
                var source = r.ToArray();
                var check = (int)(CalSum(source) ^ 0xFF) % 16;  
                var checksum = Convert.ToString(check, 16);
                r.Clear();
                r.AddRange(source);
                r.AddRange(checksum);
                source = r.ToArray();
                var tss = string.Join("", source).ToUpper();
                showList.Items.Add(tss);
                copyList.Add(tss);
                supply++;
            }
            return supply;
        }
        public static int CalSum(char[] idstr)
        {
            int ret = 0;
            for (int i = 0; i < idstr.Length; i++)
            {
                ret += idstr[i];
            }
            return ret;
        }

        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
                return BitConverter.ToInt32(bytes, 0);
            }
        }
    }
}
