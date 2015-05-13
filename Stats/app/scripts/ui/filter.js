var filter = function () {
	var filter = input.value.toLowerCase();
	window.location.hash = '/' + filter;
	var lis = document.getElementsByClassName('feature');
	var key = document.getElementById('select').value == 'Class' ? 1 : 0;

	var items = $('.features .feature').get();
	items.sort(function (a, b) {
		var keyA = a.innerText.split(' - ')[key].toLowerCase();
		var keyB = b.innerText.split(' - ')[key].toLowerCase();

		var koef = 1;
		if (keyA[0] < 'a' || keyA[0] > 'z' || keyB[0] < 'a' || keyB[0] > 'z') koef *= -1;
		if (keyA < keyB) return -1 * koef;
		if (keyA > keyB) return 1 * koef;
		return 0;
	});

	var ul = $('.features');
	$.each(items, function (i, li) {
		ul.append(li);
	});

	var flag = false;
	for (var i = 0; i < lis.length; i++) {
		var name = lis[i].getElementsByTagName('h4')[0].innerHTML;
		var summary = lis[i].getElementsByTagName('p')[0].innerHTML;
		if (name.toLowerCase().indexOf(filter) != -1 ||
			summary.toLowerCase().indexOf(filter) != -1) {
			flag = true;
			lis[i].style.display = 'list-item';
		} else
			lis[i].style.display = 'none';
	}

	$(".noresult").remove();
	if (flag) return;

	$(".search").append("<h4 class=\"noresult\">We have no'result for this  search.</h4>")
};