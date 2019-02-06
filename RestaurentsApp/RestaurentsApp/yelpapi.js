


$.getJSON('https://api.unsplash.com/users/brianhaferkamp/likes/?client_id=9da242ad85084ad7ca951738b8e7d9478fd637ba6d41cf835be09e7e1628c9dc', function (data) {
    console.log(data);

    $.each(data, function (index, value) {
        console.log(value);

        var name = value.user.name;
        var bio = value.user.bio;
        var imageURL = value.urls.regular;

        // $('.name').text(name);
        // $('.bio').text(bio);
        // $('.image img').attr('src', imageURL);

        $('.output').append('<h1 class="name">' + name + '</h1><h2 class="bio">' + bio + '</h2><div class="image"><img src="' + imageURL + '"/></div>');
    });
});