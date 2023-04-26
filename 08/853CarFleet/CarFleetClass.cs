namespace LeetCodeTasks._853CarFleet
{
    public class CarFleetClass
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            var cars = new (int Position, int Speed)[position.Length];
            for (int i = 0; i < cars.Length; i++)
                cars[i] = (position[i], speed[i]);
            Array.Sort(cars, Comparer<(int Position, int Speed)>.Create((a, b) => b.Position.CompareTo(a.Position)));

            var count = cars.Length;
            var prevTime = (double)(target - cars[0].Position) / cars[0].Speed;
            for (var i = 1; i < cars.Length; i++)
            {
                var currTime = (double)(target - cars[i].Position) / cars[i].Speed;
                if (currTime <= prevTime) count--;
                else prevTime = currTime;
            }

            return count;
        }
    }
}
