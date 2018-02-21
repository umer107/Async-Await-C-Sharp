**async Enable  await**
**Thus,**


----------


Main starts the long running method via TestAsyncAwaitMethods. That immediately returns without halting the current thread and we immediately see 'Press any key to exit' message


----------


**All this while, the LongRunningMethod is running in the background. Once its completed, another thread from Threadpool picks up this context and displays the final message
Thus, not thread is blocked.**