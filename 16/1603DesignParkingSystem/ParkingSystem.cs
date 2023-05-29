namespace LeetCodeTasks._1603DesignParkingSystem
{
    public class ParkingSystem
    {
        int _big;
        int _medium;
        int _small;

        public ParkingSystem(int big, int medium, int small)
        {
            _big = big; _medium = medium; _small = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (_big == 0) return false;
                    _big--;
                    return true;
                case 2:
                    if (_medium == 0) return false;
                    _medium--;
                    return true;
                case 3:
                    if (_small == 0) return false;
                    _small--;
                    return true;
                default: return false;
            }
        }
    }
}
