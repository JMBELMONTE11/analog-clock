# analog-clock
User should be able to input hours and minutes of the analogue clock. Program must calculate lesser angle in degrees between hours arrow and minutes arrow and provide output in the console window.
---
###
When you run this program, it will prompt the user to input the hours and minutes on the clock. The program will then calculate the angle between the hour and minute hands, and output the result in the console window.

The angle is calculated by first finding the angle between the 12 o'clock position and the hour hand. This is done by multiplying the number of hours by 30 (since there are 360 degrees in a circle, and 12 hours on a clock), and adding half of the angle that the minute hand has moved (since the hour hand moves a little bit between each hour).

Next, the angle between the 12 o'clock position and the minute hand is calculated by multiplying the number of minutes by 6 (since there are 360 degrees in a circle, and 60 minutes on a clock).

Finally, the lesser angle between the two hands is calculated by taking the absolute value of the difference between the two angles, and then checking if the angle is greater than 180 degrees. If it is, we subtract the angle from 360 to get the smaller angle.




