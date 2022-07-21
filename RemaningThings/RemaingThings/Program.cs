using System.Collections.Generic;
using System.Linq;

// Collections
int[] numbers = new int[10];
numbers[0] = 90;

int[] primes = { 2, 3, 5, 7, 11, 13 };

//string[] names = {"Niraj", "Prem"};

List<string> names = new List<string> { "Niraj", "Prem" };

Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
countryCapitals.Add("Nepal", "Ktm");
countryCapitals.Add("India", "Delhi");


// LINQ (Language INtegrated Query) - querying collections
var primesLessThan10 = primes.Where(x => x < 10);
var primeSquares = primes.Select(x => x * x);

var x = names.Where(y => y.StartsWith("P"));

// Skip, Take, orderby, groupby, join


Person p = new Person();
p.FirstName = "Np";
