# Shell Scripting

# Notes
* To Create a blank file ```touch filename.sh```
* To Execute an shell script ```bash filename.sh``` or ```./filename.sh```
* To change the permission ```chmod +x filename.ext```
* The first line of the file that is ```SheBang``` should always be ```#!/usr/bin/env bash``` or ```#!/usr/bin/bash```
* To execute any command from inside shell script, we can use ```echo $(command)```

# Variables
* Must begin with letter or a underscore
* Case Sensitive
```sh
First_Name=Piyush
Last_Name=Agarwal

echo Hi $First_Name $Last_Name
```
* Variables like ```Name = Piyush``` is not valid as space character is also taken as part of variable

# Parameters
* The parameters can be referred as ```${0}```, ```${1}``` ... upto ```${255}```
* Its better to assign the parameters to variables to give some meaning to them
```sh
./filename.sh Piyush

# ${0} -> refers to filename
# ${1} -> refers to Piyush
```

# Conditionals
* Its syntax is
```sh
if [ condition ]
then
    ...statement...
    ...statement...
elif [ condition ]
then
    ...statement...
    ...statement...
else
    ...statement...
    ...statement...
fi
```
* String comparison is done using single ```=``` equals sign

# Loops

## WHILE
* The syntax is like
```sh
#!/usr/bin/bash
COUNT=0
while [ $COUNT -lt 10 ]
do
    echo $COUNT
    ((COUNT++))
done
echo "Outside loop at count = 10" $COUNT
```

## FOR
* The syntax is like
```sh
NAMES=$@ # $ refferring to all parameters from ${1} to ${255}

for name in $NAMES
do
    echo $name
done
echo "Outside piyush"
```

# Environment Variables

```sh
#!/usr/bin/env bash

echo The Path is: $PATH
echo Computer Name: $HOSTNAME
echo UserName: $USER
echo Home is: $HOME
echo Editor is $EDITOR
echo Terminal: $TERM # type of command line terminal being used

if [ -z $EDITOR ]
then
    echo "Editor is not set"
else
    echo value of editor: $EDITOR
fi
```

# Function
```sh
function funcName(){
    ..statements..
}
funcName
```
```sh
funcName(){
    local varName=$1 # hello
    local varName2=$2  # piyush
    ..statements..
}
funcName hello piyush
```
* ```local``` is not used before variable name, it will be considered global by default
* There is no easy way of fetching some return value from a function

# Pipe
* Redirects the output of one command as to input of another command
```sh
#!/usr/bin/bash

FILES=`ls -l | sort -r | head -3`

for FILE in $FILES
do
    echo $FILE
done
```

# Reading Files
* ```IFS``` is the internal field seperator
* ```-r``` do not allow backslash to escape
```sh
#!/usr/bin/bash
while IFS='' read -r LINE
do
    echo "Line $COUNT: $LINE"
    ((COUNT++))
done < "$1"

exit 0
```
* To check if a file is edited we can do so using ```checksum``` command that is ```cksum``` which generates a unique command for a file based on the state of file
```sh
cksum filename
#output
# uniqueValue size filename
```
