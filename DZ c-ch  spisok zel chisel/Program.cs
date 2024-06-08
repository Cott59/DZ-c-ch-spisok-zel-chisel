namespace DZ_c_ch__spisok_zel_chisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1.Задача:
            //У вас есть список целых чисел. Необходимо реализовать метод, который найдет среднее арифметическое
            //всех положительных чисел в этом списке. Если в списке нет положительных чисел, метод должен выбросить пользовательское
            //исключение NoPositiveNumbersException.

            List<int> list = new List<int> { -1, 2, -8, 9, -10 };

            double ArithmeticMean(List<int>listvalue)
            {
                double Summ;
                var PositivList = listvalue.Where(i => i >= 0).ToList();
                if(PositivList.Count()!=0)
                {
                    Summ = PositivList.Sum(i => i) / PositivList.Count();
                }
                else
                {
                    throw new NoPositiveNumbersException("Нет положительных элементов");
                }
                return Summ;
            }
            string Res="";
            double Arithmetic_Mean = 0;
            try
            {
               Arithmetic_Mean = ArithmeticMean(list);
               Res = string.Format("{0:f2}", Arithmetic_Mean);
            }
            catch (NoPositiveNumbersException ex) 
            {
                Console.WriteLine($"Искл:{ex.Message}");
            }
            
            Console.WriteLine(Res);
            Console.WriteLine();
          


            Console.WriteLine("Задача 2");
            Console.WriteLine();

            ContactsManager<Contact> contactsManager = new ContactsManager<Contact>();

            try
            {
                contactsManager.AddContact("Ivan", "1565486483");
                contactsManager.AddContact("Ivan", "1678343745");
                contactsManager.AddContact("Ivann","1454833120");
                contactsManager.AddContact("Iran", "7535569933");
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine($"Искл:{ex.Message}");
            }



            var GetNameToName = contactsManager.FindContactByName("Ivan");
            foreach (Contact contact in GetNameToName)
            {
                Console.WriteLine($"Name:{contact.Name},  PhoneNumber: {contact.PhoneNumber}");
            }

            

           
                
            
           



        }
    }
}
