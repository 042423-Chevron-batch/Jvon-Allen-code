#!/bin/bash

echo -e "\nGrading System:\n\nA = 90-100\nB = 80-89\nC = 70-79\nD = 60-69\nF = 0-60"

echo -e "\nEnter a value between 0-100 and a letter grade will be determined:"

read $value

echo -e "\nYou entered: $value"


if [ $value -lt 0 ]
	then
          echo "You entered an invalid number. Uh oh, run the code again."

  #Grade is F
elif [[ $value -gt 0 && $value -le 60 ]]
        then
          echo "Your letter grade is F, you have failed badly"

  #Grade is D
elif [[ $value -gt 60 && $value -le 69 ]]
	then
          echo "Your letter grade is D, you have failed not so badly"

  #Grade is C
elif [[ $value -gt 69 && $value -le 79 ]]
        then
          echo "Your letter grade is C, you have barely passed"

  #Grade is B
elif [[ $value -gt 79 && $value -le 89 ]]
	then
          echo "Your letter grade is B, you have passed"

  #Grade is A
else [[ $value -gt 89 && $value -le 100 ]]
          echo "Your letter grade is A, great job!"
fi

