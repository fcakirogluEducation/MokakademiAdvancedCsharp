using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Events
{
 

    public class StockEventArgs:EventArgs
    {

        public int StockCount { get; set; }
    }
    public class Product
    {
        public event EventHandler<StockEventArgs> StockCheckEvent;
        //public event Action StockCheckEvent;
        public static int AlertStockCount = 500;
        public int Id { get; set; }
        public string Name { get; set; }

        private int _stock;
        public int Stock {
            get => _stock;

            set
            {
                if(value>AlertStockCount)
                {
   
                    StockCheckEvent.Invoke(this,new StockEventArgs() {  StockCount = value });
                }

                _stock = value;


            }
        }
    }



}
