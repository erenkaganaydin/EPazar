using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLOkuyucu
{
    public class ResimUrlFlyoutMenuItem
    {
        public ResimUrlFlyoutMenuItem()
        {
            TargetType = typeof(ResimUrlFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}