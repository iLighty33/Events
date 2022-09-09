using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events {

    class Acc {

        delegate void AccHandler(string sender);

        event AccHandler? Notify;

        public Acc(int sum) {
            Sum = sum;
        }
        public int Sum { get; set; }

        public void Put(int sum) {
            Sum += sum;
            Notify?.Invoke($"На счет поступило: {sum}");
        }

        public void Take(int sum) {

            if (Sum >= sum) {
                Sum -= sum;
                Notify?.Invoke($"Со счёта снято:  {sum}");
            }
            else
                Notify?.Invoke($"Недостаточно средств  {sum}");

        }
    }

}    


