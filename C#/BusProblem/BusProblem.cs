
public class BusProblem
{

    public static int LastTimeCatchTheBus(
        int[] buses,
        int[] passengers,
        int capacity)
    {
        Array.Sort(buses);
        Array.Sort(passengers);

        if (passengers[0] > buses.Length - 1)
        {
            return buses[buses.Length - 1];

        }

        int answer = -1;
        int j = 0;
        foreach (int busTime in buses)
        {
            int passengerArrival = 0;

            while (passengerArrival < capacity && j < passengers.Length && passengers[j] <= busTime)
            {
                if (j > 0 && passengers[j] != passengers[j - 1] + 1)
                {
                    answer = passengers[j] - 1;
                }
                
                j++;
                passengerArrival++;

                if (passengerArrival < capacity && j > 0 && passengers[j - 1] == busTime)
                {
                    answer = busTime;
                }
            }
        }

        return answer;
    }

    public static void Main(String[] args)
    {
        int[] bus = [10, 20];
        int[] p = [2, 17, 18, 19];
        int c = 2;

        System.Console.WriteLine(BusProblem.LastTimeCatchTheBus(bus, p, c));

    }
}