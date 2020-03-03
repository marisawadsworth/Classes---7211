using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Converter
    {
        #region Constants
        // A value that will be used whenever the constant is used in the code.

        // Constants in Converter class

        // Constant used by all the application
        public const int MAX_SPEED = 100;

        // Constant only used by in the class 
        private const int MIN_SPEED = 20;

        // Constant used by all the application  
        internal const int TEST_SPEED_1 = 20;

        // Constant used by all the application, field set to read only  
        public readonly int TEST_SPEED_2 = 20;

        public Converter()
        {
            // Test to see the constants 
            int test1 = MAX_SPEED;
            int test2 = MIN_SPEED;
            int test3 = TEST_SPEED_1;
            int test4 = TEST_SPEED_2;
        }

        #endregion

        #region Fields
        // Store data for each object.

        // Fields in Converter class

        // Field only used by in the class        
        private double miles;                       

        // Field only used by in the class        
        private double kilometres;                  

        // Field used by all the application        
        public int testIt;                          


        public Converter(int a, float b)
        {
            // Test to see the fields  
            miles = 20;
            kilometres = 20;
            testIt = 20;
        }

        #endregion

        #region Properties
        // Provide a flexible mechanism to read, write, or compute the value of a private field.

        // Properties in Converter class

        private int distance; // Private field        
        public int Distance   // Public property                       
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }


        // Standard format
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }


        // Property with extended code
        private int age;
        public int Age
        {
            get
            {
                if (age < 0) return 0;
                else return age;
            }
            set
            {
                if ((value > 0) && (value < 21))
                {
                    age = value;
                }
            }
        }

        // Auto implemented property
        // Note no field is set using this 
        // variant we are just using a 
        // property here to store our data.
        public int Height { get; set; }

        #endregion

        #region Constructors
        // Allow each object to be set up properly when it is first created.

        // Constructors in Converter class

        // Standard format property
        private int width2;
        public int Width2
        {
            get { return width2; }
            set { width2 = value; }
        }

        // Auto implemented property
        // Note no field is set using this variant we are just using a property here 
        // to store our data.

        public int Height2 { get; set; }

        /// <summary>
        /// Constructor for the Converter class. Takes no parameters and sets the 
        /// default values for the fields
        /// </summary>
        public Converter(int a, int b, int c)
        {
            width2 = 10;        // Set the default value directly to the field              
            Width2 = 11;        // Set the default value via a property to the field
            this.Width2 = 12;   // Set the default value via a property to the field 

            Height2 = 21;       // Set the default value of a property       
            this.Height2 = 22;  // Set the default value of a property        
        }

        /// <summary>
        /// Constructor for the Converter class. Takes one parameter and sets the 
        /// width field.
        /// </summary>
        /// <param name="inputWidth">User defined width size</param>
        public Converter(int inputWidth)
        {

            width = inputWidth;     // Set via the input parameter directly to the field   
            Width = inputWidth;     // Set via the input parameter using the property  
            this.Width = inputWidth;// Set via the input parameter using the property         

        }

        /// <summary>
        /// Constructor for the Converter class. Takes two parameters and sets width /// and height fields. The this keyword is used to remove the ambiguity of the 
        /// input parameters names.
        /// </summary>        
        /// <param name="width">User defined width size</param>
        /// <param name="Height">User defined height size</param>
        public Converter(int width, int Height)
        {
            this.width = width;     // Set via the input parameter directly to the field
            this.Width = width;     // Set via the input parameter directly to the field        

            this.Height = Height;   // Set the property via the input parameter       
        }

        #endregion

        #region Methods
        // Implement the behaviour of the objects.

        // Methods in Converter class

        // Test for overloading methods 

        // Integer passed to method
        public void testOverload(int a)
        {
            int x = a;
        }

        // Two integers passed to method
        public void testOverload(int a, int b)
        {
            int x = a + b;
        }

        // Integer and double passed to method
        public void testOverload(int a, double b)
        {
            int x = a + (int)b;
        }

        // Two doubles passed to method
        public void testOverload(double a, double b)
        {
            double x = a + b;
        }


        #endregion

        #region Events
        // Code that executes when an event is fired.

        #endregion

        #region Delegates
        // Allows us to link an event to a method.

        #endregion

    }
}
