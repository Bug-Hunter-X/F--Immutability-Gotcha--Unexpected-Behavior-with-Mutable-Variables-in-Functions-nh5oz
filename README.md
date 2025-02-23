# F# Immutability Gotcha: Unexpected Behavior with Mutable Variables in Functions

This example demonstrates a common pitfall in F# related to immutability.  Many developers coming from mutable-focused languages may expect functions to modify their arguments directly.  In F#, functions are immutable unless explicitly designed to be mutable, using features like `mutable`.

The `bug.fs` file shows code that behaves differently than what is initially expected by some developers due to this concept. The `bugSolution.fs` file provides corrected code that addresses the issue.

This repository helps illustrate the difference between mutable and immutable behavior in F#, a key aspect of functional programming.