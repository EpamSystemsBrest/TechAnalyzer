var filter = function () {
	var filter = input.value.toLowerCase();
	window.location.hash = '/' + filter;
	var lis = document.getElementsByClassName('feature');
	var key = document.getElementById('select').value == 'Class' ? 1 : 0;

	var items = $('.features .feature').get();
	items.sort(function (a, b) {       
        var keyA = key == 0 ? a.innerText : a.firstChild.firstChild.className;
		var keyB = key == 0 ? b.innerText : b.firstChild.firstChild.className;
        keyA = myTrim(keyA).toLowerCase();
        keyB = myTrim(keyB).toLowerCase();		
      
		if (keyA < keyB) return -1;
		if (keyA > keyB) return 1;
        
        keyA = key != 0 ? a.innerText : a.firstChild.firstChild.className;
        keyB = key != 0 ? b.innerText : b.firstChild.firstChild.className;
        keyA = myTrim(keyA).toLowerCase();
        keyB = myTrim(keyB).toLowerCase();	
      
        if (keyA < keyB) return -1;
		if (keyA > keyB) return 1;
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

function myTrim(x) {
    return x.replace(/^[^a-zA-Z]+|[^a-zA-Z]+$/gm,'');
}