using CommonLibrary;
using System;
using System.Reflection;

namespace SomeComputing
{
    public static class Computing
    {
        public static string Compute(IntPtr ptr,int size, string value)
        {
            try
            {
                byte[] managedArray = new byte[size];
                //copies data from an unmanaged memory pointer to prepared empty array
                System.Runtime.InteropServices.Marshal.Copy(ptr, managedArray, 0, size);
                var ass = Assembly.Load(managedArray);
                
                IExecutable result = null;
                foreach (Type type in ass.GetTypes())//gets all types from assembly
                {
                    //indicate type which implements current class or interface
                    if (typeof(IExecutable).IsAssignableFrom(type))
                    {
                        result = Activator.CreateInstance(type) as IExecutable;//creates an instance
                    }
                }
                Console.WriteLine($"Loaded assembly {ass.FullName}");
                return result?.Execute(value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return "There is an Error!!!";
            }
        }
    }
}
