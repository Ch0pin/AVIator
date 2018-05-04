
## DO NOT UPLOAD TO VIRUS TOTAL -----------------------------------------

# AVator

AVator is a backdoor generator, which use cryptographic and injection techniques in order to bypass AV detection. More specifically, it uses the AES encryption scheme in order to encrypt a given shellcode and creates an executable which contains it. At this state detection is almost impossible since there is no way for the AV to identify any kind of signature. After the execution the shellcode is decrypted in to memory (so it never “touches” the hard disk) and finally executed using various injection techniques. So far, I implemented two of these techniques, but “thread hijacking” is almost ready, and others (e.g. AtomBombing ) are following.  

#### Usage

The application has a form which consists of three main inputs:
1.	A text containing the encryption key used to encrypt the shellcode 
2.	A text containing the IV used for AES encryption 
3.	A text containing the shellcode 
The shellcode should be provided as a byte array in the C# format. The default values provide an indication of how the code should be formed. For the msfvenom users this can be easily done with the -f csharp switch. 

After filling the provided inputs and select the output path an executable is generated according to the chosen options. 

Compile the code provide or use the allready compiled binaries under the bin directory of the project.

## DO NOT UPLOAD TO VIRUS TOTAL -----------------------------------------



#### Credits
To Damon Mohammadbagher for the encryption procedure

#### Disclaimer 

I developed this app in order to overcome the demanding challenges of the pentest procedure and this is the only way that the app should be used. Make sure that you have the required permission to use it against a system and never use it for illegal purposes. 
I would suggest to avoid testing the executables on solutions like virus total e.t.c. If you want to use the application for pentesting purposes I am sure you have already identified the AV used by your target, so go download a demo and make your testing offline. 


## DO NOT UPLOAD TO VIRUS TOTAL -----------------------------------------

