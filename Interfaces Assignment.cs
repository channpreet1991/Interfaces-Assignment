using System;
namespace Doc
{
    public interface IQuittable
    {
        static void Quitt(); {
        	bool dosomething();
        } //Interface methods don't have bodies or modifiers
    }
  
  	class Employee : IQuittable
    {
        static void Main(string[] args)
        {
            var IQuittable = new Program();
            IQuittable.Quitt();
        }

        public bool doSomething() //methods must be public
        {
            return true;
        }
    }
}