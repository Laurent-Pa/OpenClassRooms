"""Définit les films."""

class Film:
    """Film."""

    def __init__(self, name, date):
        """Initialise le nom et la date.

        L'attribut "where" permet de savoir où est un film.
        """
        self.name = name
        self.date = date
        self.where = None
