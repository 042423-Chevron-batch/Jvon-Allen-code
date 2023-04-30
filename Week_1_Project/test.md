#!/bin/bash

echo -e "\nDo you want to buy a drink?"

read continue

while [ $continue == "yes" ] 

do
    echo -e "\nEnter your score"


    echo -e "\nThe entered score is " $score

    if [[ $score -ge 90 && $score -le 100 ]]
    then
        echo "Letter Grade A"
    
    elif [[ $score -ge 80 && $score -le 89 ]]
    then
        echo "Letter Grade B"
    
    elif [[ $score -ge 70 && $score -le  79 ]]
    then
        echo "Letter Grade C" 
    
    elif [[ $score -ge 60 && $score -le 69 ]]
    then
        echo "Letter Grade D"
    
    elif [[ $score -ge 0 && $score -le 59 ]]
    then
         echo "Letter Grade F"
    
    else 
         echo "Invalid score"
    
    echo "Do you want to enter another score? (y/n)"

    read continue
    fi

done

echo -e "\nSee ya!"


