//--------------------------------------------------------------------------------------------------------------
//
//  CSCI 447 - Machine Learning
//  Assignment #4, Fall 2019
//  Chris Major, Farshina Nazrul-Shimim, Tysen Radovich, Allen Simpson
//
//  Module for the implementation of a Particle Swarm Optimization algorithm
//
//--------------------------------------------------------------------------------------------------------------

// MODULES
//--------------------------------------------------------------------------------------------------------------
    
// Assign to Project4 Namespace
namespace Project4

// Open the modules
open Types

// Declare as a module
module rec ParticleSwarmOptimization = 


    // OBJECTS
    //--------------------------------------------------------------------------------------------------------------
        
    // Create a Population Member object to represent a member of the swarm(s)
    //type oldMember = {
    //    id                                      : int                               // ID value of the member
    //    neighbors                               : int[]                             // Array of neighbor IDs
    //    position                                : float32                           // Current position
    //    velocity                                : float32                           // Current velocity
    //    pBest                                   : float32                           // Personal best
    //}

    // Create a Population Member object to represent a member of the swarm(s)
    type Member = {
        position                                : Genome                            // Current position
        pBest                                   : Genome                            // Personal best
        velocity                                : Genome                            // Current velocity
        neighbors                               : Member[]                             // Population of neighbors
    }
       

    // FUNCTIONS
    //--------------------------------------------------------------------------------------------------------------
       
    // Function to update the position of a member
    let updateMemberPosition mem =
        mem.position = mem.position + mem.velocity                                  // Update position

    // Function to update the position of a member
    let updateMemberVelocity mem (omega : float) (c1 : float) (c2 : float) (gBest : float) =

        let r1 = rand.NextDouble()                                                  // Generate random value r1
        let r2 = rand.NextDouble()                                                  // Generate random value r2

        mem.velocity = (omega * mem.velocity) + (c1 * r1 * (mem.pBest - mem.position)) + (c2 * r2 * (gBest - mem.position))         // Update velocity


    // IMPLEMENTATIONS
    //--------------------------------------------------------------------------------------------------------------
           
        // (none)
    

//--------------------------------------------------------------------------------------------------------------
// END OF CODE