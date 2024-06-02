using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public interface IInsuranceCompany
    {
        void PayCompensation();
    }

    public class Rocket
    {
        public event EventHandler LaunchSuccessful;
        public event EventHandler Accident;

        public void Launch()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            if (randomNumber <= 5)
            {
                Accident?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                LaunchSuccessful?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public class Astronaut
    {
        public void ExitIntoOpenSpace()
        {
            Console.WriteLine("The astronauts exit into open space.");
        }
    }

    public class InsuranceCompany : IInsuranceCompany
    {
        public void PayCompensation()
        {
            Console.WriteLine("The insurance company pays a lot of money for the accident.");
        }
    }
}

