
## Guide to getting acquainted with Git
# clone directory to local machine
1. make a directory somewhere on your machine to store the folder 
2. type `git clone https://github.com/Nightsquid7/CEN-4020-Group-Project.git`
3. move into that directory (cd CEN-4020-Group-Project)
4. run some git commands: 
     * git log - show a list of commits that have been made on the current branch
     * git status - show the current files that are staged/ not staged for commit
# understand git status/staging changes
1.git status is your friend. You use this command to see what changes will be saved and unsaved and git.
 * skim this for extra info, atlassian has many great git tutorials: https://www.atlassian.com/git/tutorials/inspecting-a-repository
 
2. working directory -> staging area -> local repository -> remote repository
     
Your working directory is the directory you are working in. Once you make a change to any file, you should see those changes in the staging area  ->  you know this when you run git status:
There are three things you want to look for:
 #1 Changes to be committed:
 (use "git reset HEAD <file>..." to unstage)

 modified: hello.py

 #2 Changes not staged for commit:
 (use "git add <file>..." to update what will be committed)
 (use "git checkout -- <file>..." to discard changes in working directory)

 modified: main.py

 #3 Untracked files:
 (use "git add <file>..." to include in what will be committed)

All changes you've made that you want to commit should be under the "Changes to Be Committed" section.
If something that you have changed is in the "Change Is Not Staged for Commit" section,
      -> if you want that change to be committed you *must* add that file using git add
      git add main.py
      
 Then, once you are satisfied that all your changes are in the 'staging area', you can commit them:
 git commit -m "I changed the files hello.py and main.py and am commiting them"
 (You don't need to use the '-m' argument, but I think that it's more convenient -w without it you have to enter the commit message separately.
 
 # Branches
 
 For this project, we can have a branch called master that is the 'master' branch (Realistically we could call it whatever we want,the word master is arbitrary... ).
 Eventually want to get the project started, we will also have a develop branch.
 So the goal workflow will be 
     1. git pull from develop branch to get any new features people have been working on.
     2. make your own branch, make your changes, and pull request using the method below.
     3. when we are all satisfied with the changes, we will merge them into the master branch.
     
If you want some practice, Try cloning this repository using the instructions above, and follow the "pull request workflow" instructions below, make some changes (they can be anything/add your name to the Schedule file etc) , stage them, commit them, and then push them.

# Pull Request workflow
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


# Resolving Merge Conflicts
(after you have tried to merge/commit and are getting a warning saying there are conflicts...)
1. type git status
2. open the files that have "Unmerged paths" in your editor of choice. 
```
Unmerged paths:
  (use "git add <file>..." to mark resolution)

	both modified:   Assets/Scenes/Intro.unity - (this is the file that you are interested in, often this can be multiple files...)
  ```
3. Fix the merge conflict - https://images.app.goo.gl/Be1uxH9MHv3uXXh59 - you need to choose which changes you will keep.
VSCode has nice plug ins that can help, it should prompt you to download them automatically.

# Markdown
(Markdown isgood for making things look pretty)
https://guides.github.com/features/mastering-markdown/
