object Sub{ 
  
    // Main method 
    def main(args: Array[String]): Unit={ 
        // Creating a set 
        val s1 = Set(4, 12, 2, 31) 
          
        val s2 = Set(4, 12)
          
        // Applying subsetOf method 
        val result = s2.subsetOf(s1)
          
        // Display output
        println(result)
    } 
} 