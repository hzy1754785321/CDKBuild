using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDKBuild
{
    [Serializable]
    public class Structure
    {
        /// <summary>
        /// 类型 (1)
        /// </summary>
        public string type;
        /// <summary>
        /// id (4)
        /// </summary>
        public string id;
        /// <summary>
        /// 随机码 (n)
        /// </summary>
        public string rand;
        /// <summary>
        /// 校验码 (1)
        /// </summary>
        public int check;
    }
}
