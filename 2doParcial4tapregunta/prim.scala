def primeStream(stream: Stream[Int] = Stream.from(3, 2)): Stream[Int] = {
  stream.head #:: primeStream(stream.tail.filter(_ % stream.head != 0))
}