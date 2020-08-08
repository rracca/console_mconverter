using System;

namespace console_measurement_converter
{
    class Program
    {
        /// <summary>
        /// Converts input according to the selected conversion method.
        /// Conversion Methods:
        /// 1. Feet to Inches
        /// 2. Inches to Feet
        /// 3. Millimeters to Inches
        /// 4. Inches to Millimeters
        /// 5. Centimeters to Inches
        /// 6. Inches to Centimeters
        /// 7. Meters to Inches
        /// 8. Inches to Meters
        /// 9. Kilometers to Inches
        /// 10. Inches to Kilometers
        /// 11. Millimeters to Feet
        /// 12. Feet to Millimeters
        /// 13. Centimeters to Feet
        /// 14. Feet to Centimeters
        /// 15. Meters to Feet
        /// 16. Feet to Meters
        /// 17. Kilometers to Feet
        /// 18. Feet to Kilometers
        /// 19. Millimeters to Centimeters
        /// 20. Centimeters to Millimeters
        /// 21. Millimeters to Meters
        /// 22. Meters to Millimeters
        /// 23. Millimeters to Kilometers
        /// 24. Kilometers to Millimeters
        /// 25. Centimeters to Meters
        /// 26. Meters to Centimeters
        /// 27. Centimeters to Kilometers
        /// 28. Kilometers to Centimeters
        /// 29. Meters to Kilometers
        /// 30. Kilometers to Meters
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Please select the conversion method you want:");
            Console.WriteLine(
@"1. Feet to Inches
2. Inches to Feet
3. Millimeters to Inches
4. Inches to Millimeters
5. Centimeters to Inches
6. Inches to Centimeters
7. Meters to Inches
8. Inches to Meters
9. Kilometers to Inches
10. Inches to Kilometers
11. Millimeters to Feet
12. Feet to Millimeters
13. Centimeters to Feet
14. Feet to Centimeters
15. Meters to Feet
16. Feet to Meters
17. Kilometers to Feet
18. Feet to Kilometers
19. Millimeters to Centimeters
20. Centimeters to Millimeters
21. Millimeters to Meters
22. Meters to Millimeters
23. Millimeters to Kilometers
24. Kilometers to Millimeters
25. Centimeters to Meters
26. Meters to Centimeters
27. Centimeters to Kilometers
28. Kilometers to Centimeters
29. Meters to Kilometers
30. Kilometers to Meters");
            Console.WriteLine("Selected option: ");
            int option = Convert.ToInt32(Console.Read());

            Console.WriteLine("Value to be converted: ");
            double inputValue = Convert.ToDouble(Console.ReadLine());

            switch (option)
            {
                default: Console.WriteLine("Unexpected Error Occurred");
                    break;
            }
        }

        static double Feet_to_Inches()
        {
            double value = default;
            return value;
        }
    }
}
