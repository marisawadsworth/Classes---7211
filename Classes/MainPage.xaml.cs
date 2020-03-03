using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Classes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Define the object
        Converter testConvert;

        Converter convert1;
        Converter convert2;
        Converter convert3;


        public MainPage()
        {
            this.InitializeComponent();

            // Initialise (instantiate) object 
            testConvert = new Converter();

            // Test to see if we can see the constants 
            // A public constant is accessed by using  
            // the class name as the reference
            int test1 = Converter.MAX_SPEED;

            // An internal constant is accessed by   
            // using the class name as the reference
            int test2 = Converter.TEST_SPEED_1;

            // A read-only field is accessed using the  
            // object as a reference
            int test3 = testConvert.TEST_SPEED_2;

            // A public field is accessed by  
            // using the object as a reference
            int test4 = testConvert.testIt;

            // A public property can be set in 
            // this form
            testConvert.Distance = (int)21;

            // A public property returns the   
            // value in this form
            int test5 = testConvert.Distance;

            // Standard format test
            testConvert.Width = (int)22;
            int test7 = testConvert.Width;

            // Property with extended code
            testConvert.Age = (int)18;
            int test8 = testConvert.Age;

            // Auto implemented property
            // Note no field is set using this 
            // variant we are just using a 
            // property here to store our data.
            testConvert.Height = (int)33;
            int test9 = testConvert.Height;

            // Initialise (instantiate) objects 
            convert1 = new Converter();
            convert2 = new Converter(44);
            convert3 = new Converter(123, 456);

            // ----- Methods -----
            // Test for overloading methods 

            // Integer passed to method
            testConvert.testOverload(1);

            // Two integers passed to method
            testConvert.testOverload(1, 2);

            // Integer and double passed to 
            // method
            testConvert.testOverload(1, 3.5);

            // Two doubles passed to method
            testConvert.testOverload(1.5, 4.7);


        }
    }
}
