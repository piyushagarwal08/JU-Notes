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
4. What is Schedulingl
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
    * It can be removed in SJF
    * Faced in FCFS
10. Difference between mutex and semaphore?
    * Mutex: A mutex provides mutual exclusion, either producer or consumer can have the key (mutex) and proceed with their work. As long as the buffer is filled by producer, the consumer needs to wait, and vice versa.
    At any point of time, only one thread can work with the entire buffer. The concept can be generalized using semaphore.
    * Semaphore: A semaphore is a generalized mutex. In lieu of single buffer, we can split the 4 KB buffer into four 1 KB buffers (identical resources). A semaphore can be associated with these four buffers. The consumer and producer can work on different buffers at the same time.
11. Drawback of FCFS?
    * Convo Effect is when small process have to wait for bigger processes , it is faced in FCFS

12. What is Throughput?
    No of processes executed per unit time

13. Garbage Collection ~> The process by which periodically the unused memory space is collected back

14. Paging ~> Paging is a memory management scheme by which a computer stores and retrieves data from secondary storage for use in main memory.

15. Memory Management in Python ~> Memory management in Python involves a private heap containing all Python objects and data structures. The management of this private heap is ensured internally by the Python memory manager.

16. Race Condition ~> A race condition is a situation that may occur inside a critical section. This happens when the result of multiple thread execution in critical section differs according to the order in which the threads execute.

16. Critical Section ~> The critical section in a code segment where the shared variables can be accessed
    * The critical section problem needs a solution to synchronise the different processes. The solution to the critical section problem must satisfy the following conditions −
    1. Mutual Exclusion
    2. Progress
    3. Bounded Waitings

17. Demand paging ~>  In a system that uses demand paging, the operating system copies a disk page into physical memory only if an attempt is made to access it and that page is not already in memory.

18. Different types of Operating System:
    1. Batch Operating System.
    2. Multitasking/Time Sharing OS.
    3. Multiprocessing OS.
    4. Real Time OS.
    5. Distributed OS.
    6. Network OS.
    7. Mobile OS.
