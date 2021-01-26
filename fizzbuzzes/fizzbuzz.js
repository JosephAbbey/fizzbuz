var n = 100;

for (var i of Array(n).keys()) {
	i++;
	var o = '';
	if (!(i % 3)) {
		o += 'fizz';
	}
	if (!(i % 5)) {
		o += 'buzz';
	}
	if (o == '') {
		o = i;
	}
	console.log(o);
}
