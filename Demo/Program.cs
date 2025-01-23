namespace Demo
{
    internal class Program
    {
        static void displayInfo(IShape shape) {

            Console.WriteLine(shape.displayInfo());
        
        
        }
        static void displayNotificationMessage(INotificationService service)
        {

            Console.WriteLine(service.SendNotification("Mostafa","Don't forget to finish your homework"));


        }

        static void Main(string[] args)
        {
            #region Part 01


            #region Question 1:  What is the primary purpose of an interface in C#? 
            // a) To provide a way to implement multiple inheritance
            #endregion
            #region Question 2:  Which of the following is NOT a valid access modifier for interface members in C#?  
            //protected
            #endregion
            #region Question 3:  Can an interface contain fields in C#? 
            // c) Only if they are static
            #endregion

            #region Question 4: In C#, can an interface inherit from another interface? 
            //  b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Question 5: Which keyword is used to implement an interface in a class in C#? 
            //  d) implements   >  (:)
            #endregion

            #region Question 6: Can an interface contain static methods in C#?  
            //  a) Yes 
            #endregion
            #region Question 7: In C#, can an interface have explicit access modifiers for its members? 
            //  a) Yes, for all members
            #endregion
            #region Question 8: What is the purpose of an explicit interface implementation in C#?  
            //  b) To provide a clear separation between interface and class members 
            #endregion
            #region Question 9: In C#, can an interface have explicit access modifiers for its members? 
            //  b) No, interfaces cannot have constructor
            #endregion

            #region Question 10: In C#, can an interface have explicit access modifiers for its members? 
            //  c) By separating interface names with commas 
            #endregion
            #endregion

            #region Part 02 
            #region Question 01: 
            //Circle circle = new Circle(20);
            //Rectangle rectangle = new Rectangle(30);
            //displayInfo(circle);
            //displayInfo(rectangle);
            #endregion
            #region Question 02: 
            //IAuthenticationService authService = new BasicAuthenticationService(){ UserName="Ahmed",Password="123",Role="Admin"};

            //Console.WriteLine(authService.AuthenticateUser("Ahmed", "123")); //True
            //Console.WriteLine(authService.AuthorizeUser("Dev")); // False
            #endregion
            #region Question 03:
            //EmailNotificationService service = new EmailNotificationService();
            //PushNotificationService pushNotificationService = new PushNotificationService();    
            //SmsNotificationService smsNotificationService = new SmsNotificationService();

            //displayNotificationMessage(service);
            //displayNotificationMessage(pushNotificationService);
            //displayNotificationMessage(smsNotificationService);

            #endregion
            #endregion




        }
    }
}
