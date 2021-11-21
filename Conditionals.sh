#!user/bin/bash

read x
if [ "$x" == "Y" ] || [ "$X" == "y" ]; then
    echo "YES";
elif [ "$x" == "N" ] || [ "$X" == "n" ]; then
    echo "NO";
fi