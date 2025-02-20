input = [1,2,3,4,5,6,7,8,9,10];
high = input.length - 1;
low = 0;

function BinarySearch(input, target) {



    while (low <= high) {

        mid = low + (high - low) / 2;
        if(target === mid) { return target; }
        if(mid > target) { high = mid - 1; }
        if(mid < target) { low = mid + 1; }

        }

    return null;
}   

console.log(BinarySearch(input, 6));


