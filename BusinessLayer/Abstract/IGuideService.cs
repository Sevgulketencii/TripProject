using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGuideService: IGenericService<Guide>
    {
        void ActiveGuide(int id);
        void PassiveGuide(int id);

    }
}
