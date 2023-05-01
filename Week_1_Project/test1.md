#!/bin/bash

echo -e "\nWelcome to the Crush Drink Machine Simulator! Here is a list of flavors we have:"

#Orange flavor array
o_array=(Orange Orange Orange)

echo -e ${o_array[0]}

#Grape flavor array
g_array=(Grape Grape Grape)

echo ${g_array[0]}

#Strawberry flavor array
s_array=(Strawberry Strawberry Strawberry)

echo ${s_array[0]}

#Watermelon flavor array
w_array=(Watermelon Watermelon Watermelon)

echo ${w_array[0]}

#Pineapple flavor array
p_array=(Pineapple Pineapple Pineapple)

echo ${p_array[0]}

echo -e "\nAll drinks cost 1 dollar."
echo -e "\nPlease insert 1 dollar (1) or 5 dollars (5) to select a drink."

#takes user dollar input and validates amount
read dollar

if [ $dollar -eq 1 ]
        then
                echo -e "\nYou inserted 1 dollar"

elif [ $dollar -eq 5 ]
        then
                echo -e "\nYou inserted 5 dollars"

else
                echo -e "\nYou inserted an invalid amount"
		exit 1
fi

#prompts user with drink option
echo -e "\nDo you want to try our Orange Crush soda? We have 3 of them. (yes/no)"

read selection


#user selects to try Orange soda
if [ "$selection" == "yes" ]
      then  
		o_array=(Orange Orange)
 		echo -e "\nThere are now ${#o_array[@]} orange sodas! Your change is 4 dollars"

	if [ $dollar -eq 5 ]		
		then
		echo -e "\nDo you want another orange soda? (yes/no)"
		read another

	       if [ "$another" == "yes" ]
		then
		o_array=(Orange)
		echo -e "\nThere is now ${#o_array[@]} orange soda! Your change is 3 dollars"
		
		else
                echo -e "\nYour change is 4 dollars"
                exit 1
               fi
		
		echo -e "\nDo you want the last orange soda? (yes/no)"
		read last
              
               if [ "$last" == "yes" ]
		then
		echo -e "\nThere are no more orange sodas! Your change is 2 dollars"
		else
                echo -e "\nYour change is 3 dollars"
               fi
        fi

	if [ $dollar -eq 1 ]
		then
                echo -e "\nRerun the program to buy another drink"
	fi
fi


if [ "$selection" == "no" ]
	then
	echo -e "\nDo you want to try our Grape Crush soda? We have 3 of them. (yes/no)"
	read selection1
fi

#user selects to try Grape soda
  if [ "$selection1" == "yes" ]
      then
                g_array=(Grape Grape)
                echo -e "\nThere are now ${#g_array[@]} grape sodas! Your change is 4 dollars"

        if [ $dollar -eq 5 ]
                then
                echo -e "\nDo you want another grape soda? (yes/no)"
                read another1

               if [ "$another1" == "yes" ]
                then
                g_array=(Grape)
                echo -e "\nThere is now ${#g_array[@]} grape soda! Your change is 3 dollars"

		else
		echo -e "\nYour change is 4 dollars"
		exit 1
               fi

                echo -e "\nDo you want the last grape soda? (yes/no)"
                read last1
               if [ "$last1" == "yes" ]
                then
                echo -e "\nThere are no more grape sodas! Your change is 2 dollars"
		else
		echo -e "\nYour change is 3 dollars"
               fi
        fi
        if [ $dollar -eq 1 ]
                then
                echo -e "\nRerun the program to buy another drink"
        fi
  fi

  if [ "$selection1" == "no" ]
      then
      echo -e "\nDo you want to try our Strawberry Crush soda? We have 3 of them. (yes/no)"
      read selection2
  fi

#user selects to try Strawberry soda
  if [ "$selection2" == "yes" ]
      then
                s_array=(Strawberry Strawberry)
                echo -e "\nThere are now ${#s_array[@]} strawberry sodas! Your change is 4 dollars"

        if [ $dollar -eq 5 ]
                then
                echo -e "\nDo you want another strawberry soda? (yes/no)"
                read another2

               if [ "$another2" == "yes" ]
                then
                s_array=(Strawberry)
                echo -e "\nThere is now ${#s_array[@]} strawberry soda! Your change is 3 dollars"

                else
                echo -e "\nYour change is 4 dollars"
                exit 1
               fi

                echo -e "\nDo you want the last strawberry soda? (yes/no)"
                read last2
               if [ "$last2" == "yes" ]
                then
                echo -e "\nThere are no more strawberry sodas! Your change is 2 dollars"
                else
                echo -e "\nYour change is 3 dollars"
               fi
        fi
        if [ $dollar -eq 1 ]
                then
                echo -e "\nRerun the program to buy another drink"
        fi

  fi

  if [ "$selection2" == "no" ]
      then
      echo -e "\nDo you want to try our Watermelon Crush soda? We have 3 of them. (yes/no)"
      read selection3
  fi

#user selects to try Watermelon soda
  if [ "$selection3" == "yes" ]
      then
                w_array=(Watermelon Watermelon)
                echo -e "\nThere are now ${#w_array[@]} watermelon sodas! Your change is 4 dollars"

        if [ $dollar -eq 5 ]
                then
                echo -e "\nDo you want another watermelon soda? (yes/no)"
                read another3

               if [ "$another3" == "yes" ]
                then
                w_array=(Watermelon)
                echo -e "\nThere is now ${#w_array[@]} watermelon soda! Your change is 3 dollars"

                else
                echo -e "\nYour change is 4 dollars"
                exit 1
               fi

                echo -e "\nDo you want the last watermelon soda? (yes/no)"
                read last3
               if [ "$last3" == "yes" ]
                then
                echo -e "\nThere are no more watermelon sodas! Your change is 2 dollars"
                else
                echo -e "\nYour change is 3 dollars"
               fi
        fi
        if [ $dollar -eq 1 ]
                then
                echo -e "\nRerun the program to buy another drink"
        fi

  fi

  if [ "$selection3" == "no" ]
      then
      echo -e "\nDo you want to try our Pineapple Crush soda? We have 3 of them. (yes/no)"
      read selection4
  fi

#user selects to try Pineapple soda
  if [ "$selection4" == "yes" ]
      then
                p_array=(Pineapple Pineapple)
                echo -e "\nThere are now ${#p_array[@]} pineapple sodas! Your change is 4 dollars"

        if [ $dollar -eq 5 ]
                then
                echo -e "\nDo you want another pineapple soda? (yes/no)"
                read another4

               if [ "$another4" == "yes" ]
                then
                p_array=(Pineapple)
                echo -e "\nThere is now ${#p_array[@]} pineapple soda! Your change is 3 dollars"

                else
                echo -e "\nYour change is 4 dollars"
                exit 1
               fi

                echo -e "\nDo you want the last pineapple soda? (yes/no)"
                read last4
               if [ "$last4" == "yes" ]
                then
                echo -e "\nThere are no more pineapple sodas! Your change is 2 dollars"
                else
                echo -e "\nYour change is 3 dollars"
               fi
        fi
        if [ $dollar -eq 1 ]
                then
                echo -e "\nRerun the program to buy another drink"
        fi
 
  fi

