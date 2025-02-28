﻿// Specify the data source.
int[] scores = [97, 92, 81, 60,34,643,23,63,0,57,232,62,46];
// Define the query expression.

// IEnumerable<int> scoreQuery =
//     from score in scores
//     where score > 80
//     select score;

var scoreQuery = scores.Where(s => s >80).OrderByDescending(s => s);

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}

// Output: 97 92 81