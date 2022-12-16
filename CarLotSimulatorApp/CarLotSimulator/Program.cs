using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //*************BONUS X 2*************//
            //BONUS: I moved the bonus to the top instead of at the bottom of the code.
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.----DONE
            var lot = new CarLot();

            //----------------------------------------------------------------------------------------------------------

            //Create a seperate class file called Car----Done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable-----DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() ----------DONE
            //The methods should take one string parameter: the respective noise property--------DONE-


            //Now that the Car class is created we can instanciate 3 new cars ------DONE
            
            var momscar = new Car();  // My NOTES: This is oneway to create an instance for Car called "Dot Notation"

            momscar.Make = "Cadillac";
            momscar.Model = "ATS";
            momscar.Year = 2016;
            momscar.EngineNoise = "catcall";
            momscar.HonkNoise = "moveit";
            momscar.IsDrivable = true;

            lot.Cars.Add(momscar);
            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car-----------DONE
            var delmetrolCar = new Car() // My NOTES: This is another way to creating an instance for Car called "Object Initializer"
            {
                Year = 2023,
                Make = "BMW",
                Model = "750SI",
                EngineNoise = "....",
                HonkNoise = "money",
                IsDrivable = false

               
            };
            //add delmetrol to the carlot
            lot.Cars.Add(delmetrolCar);

            //My NOTES: ALSO: This is a 3rd way to create an instance for Car "using the contructor to allow parameter values to be placed inside properties".
            var sheliaCar = new Car(2023, "Range Rover", "Autobiography", "like a Lion", "pimpin pimpin", true);
            lot.Cars.Add(sheliaCar);
            {
                //Call each of the methods for each car-----------DONE
                //I'm calling the methods below
                momscar.MakeEngineNoise(momscar.EngineNoise);
                delmetrolCar.MakeEngineNoise(delmetrolCar.EngineNoise);
                sheliaCar.MakeEngineNoise(sheliaCar.EngineNoise);
                
            }



            Console.WriteLine($"Number of cars created:  {CarLot.numberOfCars}");  // Ex2 for StaticKeyword. This will write to console each time the number of cars increase by 1.     

                      
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console----------DONE
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year:  {car.Year}  Make:  {car.Make}  Model:  {car.Model}");
            }
        }
    }
}
