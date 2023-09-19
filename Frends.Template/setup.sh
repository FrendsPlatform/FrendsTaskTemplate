#!/bin/bash

dir="../.github/workflows"

if [[ ! -f "../LICENSE" ]]; 
then
	mv "./LICENSE" "../LICENSE"
else
	rm "./LICENSE"
fi

if [[ ! -d $dir ]];
then
	mkdir -p $dir;
fi

cd "workflows"

for filename in *; do
	echo $filename
	mv "$filename" "../../.github/workflows";
done

cd ..

echo "workflow files moved."

rmdir "workflows"

rm "setup.cmd"

rm setup.sh
