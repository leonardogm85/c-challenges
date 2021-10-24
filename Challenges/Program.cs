using System;

namespace Challenges
{
    public class Program : ProgramBase
    {
        static void Main() => Initialize();

        static void Initialize()
        {
            Clear();

            WriteMessage("Please, choose the option you want or press any other key to exit:");

            WriteOptions();

            var input = ReadMessage();

            if (Enum.TryParse<Option>(input, out var option) && Enum.IsDefined(option))
            {
                switch (option)
                {
                    case Option.PrimeNumber:
                        WriteMessage("{0}:", option.GetDescription());

                        input = ReadMessage();

                        try
                        {
                            var request = uint.Parse(input);

                            var response = new PrimeNumber((int)request);

                            WriteMessage(response.ToString());
                        }
                        catch (ArgumentException)
                        {
                            WriteError("Throw argument exception.");
                        }
                        catch (FormatException)
                        {
                            WriteError("Throw format exception.");
                        }
                        catch (OverflowException)
                        {
                            WriteError("Throw overflow exception.");
                        }
                        break;
                    case Option.FibonacciSequence:
                        WriteMessage("{0}:", option.GetDescription());

                        input = ReadMessage();

                        try
                        {
                            var request = uint.Parse(input);

                            var response = new FibonacciSequence((int)request);

                            WriteMessage(response.ToString());
                        }

                        catch (ArgumentException)
                        {
                            WriteError("Throw argument exception.");
                        }
                        catch (FormatException)
                        {
                            WriteError("Throw format exception.");
                        }
                        catch (OverflowException)
                        {
                            WriteError("Throw overflow exception.");
                        }
                        break;
                }

                LastMessages();

                ReadLine();

                Initialize();
            }

            LastMessages();
        }
    }
}
