fn binary_search(input: &[i32], target: i32) -> Option<i32> {

    // defining indices
    let mut low = 0;
    let mut high = (input.len() - 1) as i32;

    while low <= high {
        let mid = low + (high - low) / 2; // Prevents potential overflow
        
        match mid.cmp(&target) {
            std::cmp::Ordering::Equal => return Some(mid as i32),
            std::cmp::Ordering::Less => low = mid + 1,
            std::cmp::Ordering::Greater => {
                if mid == 0 { break; }
                high = mid - 1;
            }
        }
    }
    None
}

fn main() {
    let arr = vec![1,2,3,4,5,6,7,8,9,10];
    match binary_search(&arr, 7) {
        Some(index) => println!("Found at index: {}", index),
        None => println!("Target not found.")
    }
}
