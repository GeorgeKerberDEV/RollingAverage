# RollingAverage

This code targets  .NET core 2.1 and was developed using Visual Studio 2019. Please use VS 2017 or older to build solution.

After sucssessfully building the program please run the application, the application will prompt the user for a window size and a Comma Seperated Array

This Alogirthm keeps a running Average in memory, it will go through each item in the original array just once. It branches into 2 different paths depending on if the current index is greater than the window size

If the window size has not been met then it needs to recalulate the average because there are now a different number of elements in the array.
If the window size has been met than then we need to remove the last most added element (index - windowsize) and add the most recent element at the index and divide by window size because this is affecting the average.

This is beneficial because it does not require us keep around an array of elements that we average (I created an example of this in RollingAverageUtil.ComputeSlower) Which would have increased the storage required as well as increases the time complexity

One issue that might occure is that since we are using a double the percision of the averaging can be slightly off, given this it is most likely that the error is so small that it would be marginal for most applications of this program. If this is still a problem you could increase the percision on the input and outputs or use the other algorithm.



I believe the Time complexity to be O(n) we access each element in the array only once.

I also believe the Space complexity to be O(n) because a new array of length n needs to be created, a couple  temporary variables need to be created but this does not increase the complexity.

