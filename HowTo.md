## How  To do different things...

# Markdown
(Markdown isgood for making things look pretty)
https://guides.github.com/features/mastering-markdown/

# Pull Request 
(clone directory locally method)
1. Enter into the proper directory. 
2. type `git branch` and make sure you are on the right branch(skip this step if  you know you are on the right branch).
3. type `git checkout -b <branchName>` - this makes a new branch so that your new commits don't overwrite the current branch.
      * try to name your branch to match the changes you expect to make for clarity.
      * the goal is to merge the branch somewhat soon (into master or another branch)
4. Make the changes to the files that you want to change
5. (Check modified files) - type `git status`
6.    a: add the files with `git add <fileName>` or `git add -u` (-u adds multiple files, so do **step 5** to check before commiting)
      b: If all the files in the 'Untracked files' and 'Changes to be commited' sections look like what you want see **step 7**
      c: else remove files by typing `git rm <filename>`
7. type `git commit -m "type your commit message here, be specific about what you changed but you don't need to write that much"`
8. type `git push` -- Think you may need to actually run `git push --set-upstream-to=origin/etc...`but it will let you know
9. Go to Github, find the pull request button And click it. Make sure to add some reviewers, so other people can check the code.
10. After someone has reviewed the changes click 'merge' and you're done!



# clone directory to local machine
1. make a directory somewhere on your machine to store the folder 
2. type `git clone https://github.com/Nightsquid7/CEN-4020-Group-Project.git`
3. move into that directory (cd CEN-4020-Group-Project)
4. Do your work etc...
