# CRT
# Operating System

1. What is Process and what do you mean by Process Table?
    * Instance of an program in execution is an process.
2. States of an Operating System
    * New
    * Ready
    * Wait
    * Block
    * Termination / Completion
    * Suspend
3. What do you mean by thread? Difference between thread and process?
    * Single sequence of stream within a process
    * resources shared between multiple process
    * thread is lightweight
4. What is Scheduling
    * It is majorly done by short term scheduler 
    * When ready to running state a process is to be sent
    * New -> Ready or Wait -> Ready

5. Scheduling algortithm
    * SJF
    * FCFS

6. Conditions for deadlock ?
    * Two process are waiting for similar event to finish where none of them ever finish
    * Mutual Exclusion ~> Resource can not be shared
    * Hold and Wait ~> Holding one resource while waiting for other
    * No Preemption ~> Process is not allowed to take resources from process
    * Circular Wait
7. What is virtual memory and how implemented?

8. What do you mean by thrashing
    * Thrashing is a condition or a situation when the system is spending a major portion of its time in servicing the page faults, but the actual processing done is very negligible.
    * The basic concept involved is that if a process is allocated too few frames, then there will be too many and too frequent page faults. As a result, no useful work would be done by the CPU and the CPU utilisation would fall drastically.
9. What is Belady's Anomaly
    * Bélády’s anomaly is the name given to the phenomenon where increasing the number of page frames results in an increase in the number of page faults for a given memory access pattern.
10. Difference between mutex and semaphore?
    * Mutex: A mutex provides mutual exclusion, either producer or consumer can have the key (mutex) and proceed with their work. As long as the buffer is filled by producer, the consumer needs to wait, and vice versa.
    At any point of time, only one thread can work with the entire buffer. The concept can be generalized using semaphore.
    * Semaphore: A semaphore is a generalized mutex. In lieu of single buffer, we can split the 4 KB buffer into four 1 KB buffers (identical resources). A semaphore can be associated with these four buffers. The consumer and producer can work on different buffers at the same time.
11. Drawback of FCFS?
    * Convo Effect is when small process have to wait for bigger processes , it is faced in FCFS


