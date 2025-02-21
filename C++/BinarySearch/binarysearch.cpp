#include <iostream>
#include <span>
#include <vector>
using namespace std;

int binarySearch(span<const int> data, int target) {
    int high = data.size() - 1; // Last index
    int low = 0;                // First index
    while (low <= high)
    {
        int guess = low + (high - low) / 2; // Mid point calculation.
        if (data[guess] == target) {        
            cout << "Target found at position " << guess;
            return guess; }
        if (data[guess] < target) {
            low = guess + 1;
        } else {
            high = guess - 1;
        }
    }
    cout << "Target not found." << endl;
    return -1;
}

int main() {
    // Create a sorted array for the search
    vector<int> sortedArray = {1,2,3,4,5,6,7,8,9,10};

    span<const int> input(sortedArray);
    int result = binarySearch(input, 6);
}