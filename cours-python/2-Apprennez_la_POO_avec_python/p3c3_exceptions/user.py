"""Gestion des utilisateurs"""

import re # for RegEx in password validation

def validate_username(username):
        """valide que le nom d'utilisateur fait au moins 3 caractères"""
        return len(username) >= 3

def validate_password(password):
        """valide que le mot de passe contient au moins une lettre et un chiffre"""
        number_in_password =  bool(re.search(r'\d', password))
        letter_in_password =  bool(re.search(r'[a-zA-Z]', password))
        return letter_in_password and number_in_password


class MyAppException(Exception):
    """Gère les exceptions définies pour l'application."""
    pass

class MyAppExceptionNameTooShort(MyAppException):
    """Erreur sur le nom d'utilisateur."""
    def __init__(self, username, base_message="This user name not valid !", *args, **kwargs):
        """Initialise le message."""
        msg = f"{base_message} Username: {username}"
        super().__init__(msg, *args, **kwargs)

class MyAppExceptionPasswordTooWeak(MyAppException):
    """Erreur sur le mot de passe."""
    def __init__(self, msg="", *args, **kwargs):
        """Init le message."""
        msg = msg or "Le mot de passe n'est pas valide!"
        super().__init__(msg, *args, **kwargs)

class User:
    """Un utilisateur"""
    def __init__(self, username, password):
            """Initialise le nom et mot de passe"""
            if (not validate_username(username)):
                 raise MyAppExceptionNameTooShort(username)
            if (not validate_password(password)):
                 raise MyAppExceptionPasswordTooWeak(password)
            self.username = username
            self.password = password

if __name__ == "__main__":
    # Tests divers
    test_cases = [
        ("John", "supersecret2", True),   # Valide
        ("Jo", "supersecret2", False),    # Nom trop court
        ("John", "supersecret", False),   # Pas de chiffre
        ("John", "123456789", False),     # Pas de lettre
        ("Alice", "Password1", True),     # Valide
    ]

    for username, password, should_succeed in test_cases:
        try:
            user = User(username, password)
            if should_succeed:
                print(f"✅ {username}: Utilisateur créé avec succès")
            else:
                print(f"❌ {username}: Devrait avoir échoué mais a réussi")
        except MyAppException as e:
            if not should_succeed:
                print(f"✅ {username}: Échec attendu - {e}")
            else:
                print(f"❌ {username}: Échec inattendu - {e}")
