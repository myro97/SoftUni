function getSmallestNum(a, b, c) {
  let min = Number.MAX_VALUE;

  function checkNum(num) {
    if (min > num) {
      min = num;
    }

    return min;
  }

  min = checkNum(a);
  min = checkNum(b);
  min = checkNum(c);

  console.log(min);
}

getSmallestNum(2, 5, 3);
