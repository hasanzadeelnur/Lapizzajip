function deleteModal(elementId) {
    event.preventDefault();

    if (confirm('Are you sure?')) {
        document.getElementById(elementId).submit();
    }
}

