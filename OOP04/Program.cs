namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1  Abstraction
            //هو مفهوم في الـ OOP يركز على إخفاء التفاصيل البرمجية الداخلية المعقدة للخدمة أو الكائن وإظهار الوظائف والميزات الأساسية والضرورية فقط للمستخدم.

            //لأنه يقلل من تعقيد النظام (Reduces Complexity)، ويسمح بالتوسع المستقبلي بسهولة عبر إجبار الكلاسات الابنة على إتباع "عقد" (Contract) أو هيكل محدد دون الانشغال بكيفية تنفيذ باقي أجزاء البرنامج.
            #endregion

            #region Q2: Abstract Classes vs. Interfaces
            //Abstract Class : يمكن أن يحتوي على متغيرات (Fields)، ودوال مكتوبة بالتفصيل
            //(Concrete methods)، ودوال مجردة (Abstract methods). يُستخدم عندما تكون الكلاسات المشتقة تتشارك في علاقة وراثة حقيقية ("Is-A") وبها كود مشترك
            //Interface : لا يمكن أن يحتوي على متغيرات (Fields) أو دوال مكتوبة بالتفصيل (Concrete methods)، بل يحتوي فقط على توقيعات الدوال (Method Signatures). يُستخدم عندما تكون الكلاسات المشتقة تتشارك في علاقة سلوك مشترك ("Can-Do") دون الحاجة إلى وراثة حقيقية

            //نختار الـ Interface عندما نريد إضافة ميزات وسلوكيات مشتركة لكلاسات مختلفة تماماً وليس بينها وراثة، أو عندما
            //نحتاج لتطبيق الـ Multiple Inheritance (أن يرث الكلاس أكثر من عقد واحد) لأن C# لا تدعم الوراثة المتعددة من الكلاسات

            //لا، لا يمكن للكلاس أن يرث إلا من كلاس مجرد واحد فقط (Single Inheritance)
            //نعم، يمكن للكلاس أن يطبق (Implement) أكثر من Interface بنفس الوقت دون أي مشكلة
            #endregion

            #region Practical
            DeliveryCenter center = new DeliveryCenter("Main Center");

            StandardShipment std = new StandardShipment("SH001", "Laptop", 3, 80, new DeliveryAddress("Street 1", "Cairo"));
            ExpressShipment exp = new ExpressShipment("SH002", "Mobile Phone", 2, 60, new DeliveryAddress("Street 2", "Giza"), 30);
            InternationalShipment inter = new InternationalShipment("SH003", "Television", 8, 120, new DeliveryAddress("Street 3", "Berlin"), "Germany", 100);

            center.AddShipment(std);
            center.AddShipment(exp);
            center.AddShipment(inter);

            center.PrintAllShipments();

            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("==========================================");
            DeliveryReport.PrintShipment(std);
            DeliveryReport.PrintShipment(exp);
            DeliveryReport.PrintShipment(inter);

            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            Console.WriteLine("==========================================");
            DeliveryReport.PrintInsurance(std);
            DeliveryReport.PrintInsurance(exp);
            DeliveryReport.PrintInsurance(inter);

            Console.WriteLine("\nTesting ITrackable[] Array Polymorphism:");
            ITrackable[] trackables = new ITrackable[] { std, exp, inter };
            foreach (var item in trackables)
            {
                Console.WriteLine(item.GetTrackingStatus());
            }

            Console.WriteLine("\nTesting IInsurable[] Array Polymorphism:");
            IInsurable[] insurables = new IInsurable[] { std, exp, inter };
            foreach (var item in insurables)
            {
                Console.WriteLine($"Insurance: {item.CalculateInsurance():0.00} EGP");
            }

            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

            Console.ReadKey();
            #endregion

        }
    }
}
