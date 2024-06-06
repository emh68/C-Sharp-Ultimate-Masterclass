// using System;
// using System.Drawing;

// int points = 10;


// char ConvertPointsToGrade(int points)
// {
//     string result;
//     switch (points)
//     {
//         case 10:
//         case 9:
//             return 'A';

//         case 8:
//         case 7:
//         case 6:
//             return 'B';

//         case 5:
//         case 4:
//         case 3:
//             return 'C';

//         case 2:
//         case 1:
//             return 'D';

//         case 0:
//             return 'E';

//         default:
//             return '!';
//     }
// }

char[,] letters = new char[2, 3];

letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

Console.WriteLine(letters);


Console.ReadKey();