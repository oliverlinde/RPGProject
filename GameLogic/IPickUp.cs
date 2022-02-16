using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Items;

namespace GameLogic
{
    public interface IPickUp
    {
        public void PickUp(Item item);
        public void DropItem(Item item);
    }
}
