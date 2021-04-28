using System;
using System.Text;
using Doushi;

namespace Doushi_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
            Console.WriteLine("Doushi Japanese verb conjugator");
            Console.WriteLine("Type 'exit' to quit");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Dictionary form verb:");
                Console.Write("> ");
                var verb = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(verb))
                    continue;
                else if (verb.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    return;

                if (verb.Length < 2)
                    continue;

                Console.WriteLine("Reading (optional)");
                Console.Write("> ");
                var reading = Console.ReadLine();

                Console.WriteLine("Verb type (Auto detects when the reading is provided (not totally accurate))\n'1': Ichidan\n'2': Godan\n'3': Special Suru/Kuru");
                Console.Write("> ");
                var t = Console.ReadLine();
                var type = t switch
                {
                    "1" => Doushi.Type.ICHIDAN,
                    "2" => ((Func<Doushi.Type>)(() =>
                    {
                        var t = Conjugator.TryFindType(verb, reading.Length >= 2 ? reading : verb);
                        return t != Doushi.Type.ICHIDAN ? t : Doushi.Type.GODAN_RU;
                    }))(),
                    "3" => Conjugator.TryFindType(verb, verb),
                    _ => reading.Length >= 2 ? Conjugator.TryFindType(verb, reading) : Doushi.Type.UNKNOWN
                };

                Console.WriteLine();
                Console.WriteLine($"　{verb} {type}\n\n　Affirmative | Negative\n");

                var conj = Conjugator.Conjugate(verb, type, reading);

                if (conj != null)
                {
                    Console.WriteLine($"　-> Non-Past: {conj.NonPast.Affirmative} | {conj.NonPast.Negative}\n");
                    Console.WriteLine($"　-> Non-Past Polite: {conj.NonPastPolite.Affirmative} | {conj.NonPastPolite.Negative}\n");
                    Console.WriteLine($"　-> Past: {conj.Past.Affirmative} | {conj.Past.Negative}\n");
                    Console.WriteLine($"　-> Past Polite: {conj.PastPolite.Affirmative} | {conj.PastPolite.Negative}\n");
                    Console.WriteLine($"　-> Te Form: {conj.TeForm.Affirmative} | {conj.TeForm.Negative}\n");
                    Console.WriteLine($"　-> Potential: {conj.Potential.Affirmative} | {conj.Potential.Negative}\n");
                    Console.WriteLine($"　-> Passive: {conj.Passive.Affirmative} | {conj.Passive.Negative}\n");
                    Console.WriteLine($"　-> Causative: {conj.Causative.Affirmative} | {conj.Causative.Negative}\n");
                    Console.WriteLine($"　-> Causative Passive: {conj.CausativePassive.Affirmative} | {conj.CausativePassive.Negative}\n");
                    Console.WriteLine($"　-> Imperative: {conj.Imperative.Affirmative} | {conj.Imperative.Negative}\n");
                }
                else
                {
                    Console.WriteLine("Invalid input");                   
                }
                Console.WriteLine();
            }
        }
    }
}
