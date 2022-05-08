using System;

namespace Tictactoe
{
    class Program
    {
        static void Main(string [] args)
        {
            string board = "| 1 | 2 | 3 |\n|-----------|\n| 4 | 5 | 6 |\n|-----------|\n| 7 | 8 | 9 |\n";
            char xo = 'X';
            int turn = 0;
            List<string> list = new List<string>();
                        
            while (true)
            {
                if (CheckIfWin(board, turn)){
                    Console.WriteLine(xo + ": Won");
                    break;
                }
                Console.WriteLine(board);
                var checkTurn = turn % 2 == 0 ? xo = 'X' : xo = 'O';
                string input = Convert.ToString(Console.ReadLine());
                switch (input)
                {
                    case "1":
                        list = ChangeNum(board, '1', xo, turn);
                        board = list[0];
                        turn = Convert.ToInt32(list[1]);
                        break;
                    case "2":
                        list = ChangeNum(board, '2', xo, turn);
                        board = list[0];
                        turn = Convert.ToInt32(list[1]);
                        break;
                    case "3":
                        list = ChangeNum(board, '3', xo, turn);
                        board = list[0];
                        turn = Convert.ToInt32(list[1]);
                        break;
                    case "4":
                        list = ChangeNum(board, '4', xo, turn);
                        board = list[0];
                        turn = Convert.ToInt32(list[1]);
                        break;
                    case "5":
                        list = ChangeNum(board, '5', xo, turn);
                        board = list[0];
                        turn = Convert.ToInt32(list[1]);
                        break;
                    case "6":
                        list = ChangeNum(board, '6', xo, turn);
                        board = list[0];
                        turn = Convert.ToInt32(list[1]);
                        break;
                    case "7":
                        list = ChangeNum(board, '7', xo, turn);
                        board = list[0];
                        turn = Convert.ToInt32(list[1]);
                        break;
                    case "8":
                        list = ChangeNum(board, '8', xo, turn);
                        board = list[0];
                        turn = Convert.ToInt32(list[1]);
                        break;
                    case "9":
                        list = ChangeNum(board, '9', xo, turn);
                        board = list[0];
                        turn = Convert.ToInt32(list[1]);
                        break;
                    default:
                        Console.WriteLine("Didn't understand please try again.");
                        turn--;
                        break;
                }
                if (turn == 8) {break;}
                turn++;
            }
            Console.ReadLine();
        }   

        static List<string> ChangeNum(string board, char place, char xo, int turn)
        {
            List<string> list = new List<string>();
            string board1 = board.Replace(place, xo);

            list.Add(board1);

            if (board1 == board)
            {
                turn--;             
            }
            list.Add(Convert.ToString(turn));
            return list;
        }

        static bool CheckIfWin(string board, int turn)
        {
            List<string> subStrings = new List<string>();
            foreach (string str in board.Split('|'))
            {
                subStrings.Add(str);
            }
            string a = subStrings[1].Substring(1, 1);
            string b = subStrings[2].Substring(1, 1);
            string c = subStrings[3].Substring(1, 1);
            string d = subStrings[7].Substring(1, 1);
            string e = subStrings[8].Substring(1, 1);
            string f = subStrings[9].Substring(1, 1);
            string g = subStrings[13].Substring(1, 1);
            string h = subStrings[14].Substring(1, 1);
            string i = subStrings[15].Substring(1, 1);

            List<string> places = new List<string>();
            bool returnValue;

            // Horizontal lines of WINNING
            places.Add(a); places.Add(b); places.Add(c);
            returnValue = CheckPlaces(places);
            if (returnValue) { return true; }
            places[0] = d; places[1] = e; places[2] = f;
            returnValue = CheckPlaces(places);
            if (returnValue) { return true; }
            places[0] = g; places[1] = h; places[2] = i;
            returnValue = CheckPlaces(places);
            if (returnValue) { return true; }

            places[0] = a; places[1] = d; places[2] = g;
            returnValue = CheckPlaces(places);
            if (returnValue) { return true; }
            places[0] = b; places[1] = e; places[2] = h;
            returnValue = CheckPlaces(places);
            if (returnValue) { return true; }
            places[0] = c; places[1] = f; places[2] = i;
            returnValue = CheckPlaces(places);
            if (returnValue) { return true; }

            places[0] = a; places[1] = e; places[2] = i;
            returnValue = CheckPlaces(places);
            if (returnValue) { return true; }
            places[0] = c; places[1] = e; places[2] = g;
            returnValue = CheckPlaces(places);
            if (returnValue) { return true; }

            return false;

            static bool CheckPlaces(List<string> places)
            {
                if (places[0] == places[1] && places[1] == places[2]) // If all three are the same char
                {
                    return true;
                }
                return false;
            }           
        }
    }
}
