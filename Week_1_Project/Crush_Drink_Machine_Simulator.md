#!/bin/bash

echo -e "\nWelcome to the Crush Drink Machine Simulator!... Here is a list of flavors we have:"

#Orange flavor array
o_array=(Orange Orange Orange Orange Orange Orange)

echo -e ${o_array[0]}

#Grape flavor array
g_array=(Grape Grape Grape Grape Grape Grape)

echo ${g_array[0]}

#Strawberry flavor array
s_array=(Strawberry Strawberry Strawberry Strawberry Strawberry Strawberry)

echo ${s_array[0]}

#Watermelon flavor array
w_array=(Watermelon Watermelon Watermelon Watermelon Watermelon Watermelon)

echo ${w_array[0]}

#Pineapple flavor array
p_array=(Pineapple Pineapple Pineapple Pineapple Pineapple Pineapple)

echo ${p_array[0]}

echo -e "\nAll drinks cost 1 dollar... Please insert 1 dollar (1) or 5 dollars (5)."

#takes user dollar input and validates amount
read dollar

if [ $dollar -eq 1 ]
	then 
		echo -e "\nYou entered 1 dollar"
elif [ $dollar -eq 5 ]
	then
		echo -e "\nYou entered 5 dollars"
else
		echo -e "\nYou entered invalid amount" 
fi

echo -e "\nWhich flavor would you like to try?"

read flavor

echo -e "\nYou selected: $flavor"
