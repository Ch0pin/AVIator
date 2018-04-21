# AVator

AVator is a backdoor generator, which use cryptographic and injection techniques in order to bypass AV detection. More specifically, it uses the AES encryption scheme in order to encrypt a given shellcode and creates an executable which contains it. At this state detection is almost impossible since there is no way for the AV to identify any kind of signature. After the execution the shellcode is decrypted in the memory (so it never “touches” the hard disk) and finally executed using various injection techniques. So far, I implemented two of these techniques, but “thread hijacking” is almost ready, and others (e.g. AtomBombing ) are following.  

#### An AV evasion project 

The application has a form which consists of three main inputs:
1.	A text containing the encryption key used to encrypt the shellcode 
2.	A text containing the IV used for AES encryption 
3.	A text containing the shellcode 
The shellcode should be provided as a byte array in the C# format. The default values provide an indication of how the code should be formed. For the msfvenom users this can be easily done with the -f csharp switch. 

