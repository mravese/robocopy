# Robocopy
The Microsoft Windows's file replication command with a basic user interface, made in C# using WPF. I started this project with the idea of making it easier to use, without the need to open the Windows console. 

# Overview
By simply selecting the source and destination, with one of the copy options, you can run robocopy and check the progress on the console. If there are blanks in the selected source, the program will ask for permission to remove them before executing the command. This is because Robocopy does not allow spaces between the path, so this program renames the folders.

# To be fixed
<li>After removing blanks from the source path, it should leave the folders with their original names. But this has to be replaced with the addition of quotation marks around both the source and destination paths, so that way robocopy can run with spaces in between. </li>
<li>Still struggling to kill cmd process after the user decides to close the app</li>
<li>Visuals</li>

# Future functionalities
<li>More copy options</li>
<li>Language change</li>
