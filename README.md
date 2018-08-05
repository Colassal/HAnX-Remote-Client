# HAnX-Remote-Client
A windows client for connecting to sys-netcheat nintendo switch homebrew. This does not contain sys-netcheat, you will need to use the github page to set that up first this is only for communicating from a windows pc to the switch.

sys-netcheat github page: https://github.com/jakibaki/sys-netcheat

DOWNLOAD THE LATEST FROM RELEASES!

1) Run HAnX_RemoteConnect.Exe (Probably needs admin privledges - just saying)
2) Chose the first option to enter your switch's IP Address and port
3) Wait for it to let you know it is connected
4) Enter commands as listed on the sys-netcheat github page
5) There may be points where the client is waiting on the server to send data - you may have to enter something into the console and hit enter for it to continue.
6) Profit!

A UI with address saving and more memory editor like features is planned (some things may be limited on the sys-netcheat end, but jakibaki has made a pretty freakin great sys module so make sure to give him thanks!).

I only have abut 2-3 hours to dedicate on weekends - with some time on weekdays. If you are interested in improving the code please feel free to submit pull requests and I will work to merge them as fast as I can.

This is very much a WIP, my code is less than stellar and I am not responsible for any unintended issues this may cause including but not limited to:

Crashing your computer
Bricking your Switch
Making your printer want blood
Creating Nuclear arms
Gaining sentience and hunting Sarah Connor
(You get my point)

Changelog:

V 1.2.0 -- 8/4/2018
Fixed Issues
  -- Actually works now!
  -- Actually tested and debuged for sys-netcheat!
  -- Faster than before!
  -- Less change of stupid failure!

New
  -- Added classes to start on V2 update (Async, address saving, GUI)
 
Known Issues To be Fixed In V2
  -- May show an input ">>" during a search, this means the server is sending a piece that the client didn't see yet. Just enter  anything and hit enter and it will continue.
  -- Probably some real weird stuff.
  
V 1.00 -- 7/30/2018

Created first version
- Console based commands
- IP & Port entry
- TCP Client implemented for send/recieve

** VERSION HAS NOT BEEN TESTED YET - PLEASE COMMENT IF YOU HAVE TESTED THIS BEFORE I HAVE A CHANCE **
