using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antylabirynt
{
    internal class LeeAlgorithm
    {
        public static Queue<Tuple<int, int>> getTheShortestPath(int[,] stateMatrix, Tuple<int, int> entryCoords, Tuple<int, int> endCoords)
        {
            (int, int[,]) leeReturn = leeAlgorithm(stateMatrix, entryCoords, endCoords);

            // No shortest path or cords not in the matrix
            if (leeReturn.Item1 == -1)
            {
                return null;
            }

            int xStart = entryCoords.Item1;
            int yStart = entryCoords.Item2;

            int xEnd = endCoords.Item1;
            int yEnd = endCoords.Item2;

            // We're going reverse from the finish to the start
            int x = xEnd;
            int y = yEnd;

            int distance = leeReturn.Item1; // the distance to the finish line
            int[,] distanceMatrix = leeReturn.Item2; // distance matrix

            Queue<Tuple<int, int>> moveQueue = new Queue<Tuple<int, int>>();
            moveQueue.Enqueue(new Tuple<int, int>(xEnd, yEnd));

            // left, up, right and down moves
            int[] moveX = { -1, 0, 1, 0 };
            int[] moveY = { 0, 1, 0, -1 };

            while (true)
            {
                // if we already got to the starting point
                if (x == xStart && y == yStart)
                {
                    break;
                }

                for (int k = 0; k < 4; k++)
                {
                    if (isValid(new Tuple<int, int>(x + moveX[k], y + moveY[k]), distanceMatrix))
                    {
                        int currentDistance = distanceMatrix[x + moveX[k], y + moveY[k]];
                        if (currentDistance == distance - 1)
                        {
                            // get this element into the queue, change the distance we're at
                            // and move the coordinates to current place
                            moveQueue.Enqueue(new Tuple<int, int>(x + moveX[k], y + moveY[k]));
                            distance = currentDistance;
                            x = x + moveX[k];
                            y = y + moveY[k];
                            break;
                        }
                    }
                }
            }
            // I need to reverse this queue, because I added the elements in reversed order, no other choice 
            return new Queue<Tuple<int, int>>(moveQueue.Reverse());
        }

        private static (int, int[,]) leeAlgorithm(int[,] stateMatrix, Tuple<int, int> entryCoords, Tuple<int, int> endCoords)
        {
            // if coordinates aren't inside the matrix
            if (!(isValid(entryCoords, stateMatrix) && (isValid(endCoords, stateMatrix))))
            {
                return (-1, stateMatrix);
            }
            //Console.Write("got Here too\n");

            int xStart = entryCoords.Item1;
            int yStart = entryCoords.Item2;
            int xEnd = endCoords.Item1;
            int yEnd = endCoords.Item2;

            // helpful in moving left, up, right and down
            int[] moveX = { -1, 0, 1, 0 };
            int[] moveY = { 0, 1, 0, -1 };

            int xSizeMatrix = stateMatrix.GetLength(0);
            int ySizeMatrix = stateMatrix.GetLength(1);

            bool[,] visitedMatrix = new bool[xSizeMatrix, ySizeMatrix]; // if the spot was visited by the algorithm 
            int[,] distanceMatrix = new int[xSizeMatrix, ySizeMatrix]; // matrix with the distances

            for (int p = 0; p < xSizeMatrix; p++)
            {
                for (int q = 0; q < ySizeMatrix; q++)
                {
                    distanceMatrix[p, q] = int.MaxValue;
                }
            }
            distanceMatrix[xStart, yStart] = 0;

            Queue<Tuple<int, int, int>> queue = new Queue<Tuple<int, int, int>>();

            // we start from this point so it will be visited
            visitedMatrix[xStart, yStart] = true;
            queue.Enqueue(new Tuple<int, int, int>(xStart, yStart, 0));

            int min_distance = int.MaxValue;

            while (queue.Count > 0)
            {
                Tuple<int, int, int> Node = queue.Dequeue();
                int i = Node.Item1;
                int j = Node.Item2;
                int dist = Node.Item3;

                if (i == xEnd && j == yEnd)
                {
                    min_distance = dist;
                    break;
                }

                for (int k = 0; k < 4; k++)
                {
                    if (canVisit(new Tuple<int, int>(i + moveX[k], j + moveY[k]), stateMatrix, visitedMatrix))
                    {
                        visitedMatrix[i + moveX[k], j + moveY[k]] = true;
                        queue.Enqueue(new Tuple<int, int, int>(i + moveX[k], j + moveY[k], dist + 1));
                        distanceMatrix[i + moveX[k], j + moveY[k]] = (dist + 1);
                    }
                }
            }

            if (min_distance != int.MaxValue)
            {
                return (min_distance, distanceMatrix);
            }
            return (-1, distanceMatrix);
        }

        private static bool canVisit(Tuple<int, int> coordinates, int[,] stateMatrix, bool[,] visitedMatrix)
        {
            // Here you can change what fileds (numbers) can our player step onto (means what int is defined as an empty field)
            int safeToStepOn = 1;
            int finishLine = 100;
            int burger = 5;
            int bomb = 30;
            int xCoordinate = coordinates.Item1;
            int yCoordinate = coordinates.Item2;

            if (isValid(coordinates, stateMatrix)
                && !visitedMatrix[xCoordinate, yCoordinate] &&
                (stateMatrix[xCoordinate, yCoordinate] == safeToStepOn
                || stateMatrix[xCoordinate, yCoordinate] == finishLine
                || stateMatrix[xCoordinate, yCoordinate] == burger
                || stateMatrix[xCoordinate, yCoordinate] == bomb))

                return true;
            else
                return false;
        }

        private static bool isValid(Tuple<int, int> coordinates, int[,] matrix)
        {
            int xCoordinate = coordinates.Item1;
            int yCoordinate = coordinates.Item2;
            int xSizeMatrix = matrix.GetLength(0);
            int ySizeMatrix = matrix.GetLength(1);

            if (xCoordinate >= 0 && xCoordinate < xSizeMatrix && yCoordinate >= 0 && yCoordinate < ySizeMatrix)
                return true;
            else
                return false;
        }
    }
}
